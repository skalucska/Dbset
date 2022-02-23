using GestionEmploye.Common.Interface;
using GestionEmploye.Common.Model;
using GestionEmploye.ViewModels.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GestionEmploye.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private EmployeViewModel employeSelectionne;
        private IEmployeDataProvider _employeDataProvider;

        public MainViewModel(IEmployeDataProvider employeDP)
        {
            _employeDataProvider = employeDP;
            Employes = new(); // instanciation de la liste sucre syntaxique new()
            ChargerCmd = new DelegateCommand(Charger);

        }

        public ObservableCollection<EmployeViewModel> Employes { get; }
        public DelegateCommand ChargerCmd { get; }
        public ObservableCollection<Role> Roles { get; } = new();

        public EmployeViewModel EmployeSelectionne 
        { 
            get => employeSelectionne;
            set
            {
                if (employeSelectionne != value)
                {
                    employeSelectionne = value;
                    RaisePropertyChanged();
                    RaisePropertyChanged(nameof(PeutAfficherDetails));
                }
            } 
        }
        public bool PeutAfficherDetails => employeSelectionne != null;


        public void Charger()
        {
            var employes = _employeDataProvider.ChargerEmployes();
            var roles = _employeDataProvider.ChargerRoles();

            Employes.Clear();
            foreach (var employe in employes)
            {
                Employes.Add(new EmployeViewModel(employe, _employeDataProvider)); 
            }

            Roles.Clear();
            foreach (var jobRole in roles)
            {
                Roles.Add(jobRole);
            }
        }


    }
    }
