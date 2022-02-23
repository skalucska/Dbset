using GestionEmploye.Common.Model;
using GestionEmploye.Common.Interface;
using System;
using GestionEmploye.Common;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using GestionEmploye.ViewModels.Command;

namespace GestionEmploye.ViewModels
{
    public class EmployeViewModel
    {
        private Employe _employe;
        private IEmployeDataProvider _employeDP;


        public EmployeViewModel(Employe employe, IEmployeDataProvider employeDP)
        {
            _employe = employe;
            _employeDP = employeDP;
            SauvegarderCmd = new DelegateCommand(Sauvegarder, ()=>PeutSauvegarder);
        }

        public DelegateCommand SauvegarderCmd { get; }
        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged([CallerMemberName] string nomPropriete = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nomPropriete));
        }

        public bool PeutSauvegarder => !string.IsNullOrWhiteSpace(Prenom)
                                   && !string.IsNullOrWhiteSpace(Nom);

        
        
        public void Sauvegarder()
        {
            _employeDP.SauvegarderEmploye(_employe);
        }
        public string Prenom 
        {
            get => _employe.Prenom;
            set{
                if (_employe.Prenom != value)
                {
                    _employe.Prenom = value;
                    RaisePropertyChanged();
                    RaisePropertyChanged(nameof(PeutSauvegarder));
                    SauvegarderCmd.RaiseCanExecuteChanged();

                }
            }
        }
        public string Nom 
        {
            get => _employe.Nom;
            set{
                if (_employe.Nom != value)
                {
                    _employe.Nom = value;
                    RaisePropertyChanged();
                    RaisePropertyChanged(nameof(PeutSauvegarder));
                    SauvegarderCmd.RaiseCanExecuteChanged();
                }
            }
        }
        public DateTimeOffset DateEmbauche 
        { 
            get => _employe.DateEmbauche;
            set {
                if (_employe.DateEmbauche != value)
                {
                    _employe.DateEmbauche = value;
                    RaisePropertyChanged();


                }
            } 
        }

        public DateTime DateEmbaucheWpf
        {
            get => _employe.DateEmbauche.DateTime;
            set
            {
                if (_employe.DateEmbauche != value)
                {
                    _employe.DateEmbauche = value;
                    RaisePropertyChanged();

                }
            }
        }

        public int RoleId 
        {
            get => _employe.RoleId;
            set
            {
                if (_employe.RoleId != value)
                {
                    _employe.RoleId = value;
                    RaisePropertyChanged();

                }
            }
        }
        public bool EstPiloteDeLigne 
        { 
            get => _employe.EstPiloteDeLigne;
            set
            {
                if (_employe.estPiloteDeLigne != value)
                {
                    _employe.EstPiloteDeLigne = value;
                    RaisePropertyChanged();

                }
            }
        }


    }
}
