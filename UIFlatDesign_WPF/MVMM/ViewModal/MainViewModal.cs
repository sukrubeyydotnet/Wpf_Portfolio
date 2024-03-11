using System;
using UIFlatDesign_WPF.Core;

namespace UIFlatDesign_WPF.MVMM.ViewModal
{
    class MainViewModal : ObservableObject
    {
        private object _currentView;

        public HomeViewModal homeViemModal { get; set; }
        public ProjectsViewModal projectsViewModal { get; set; }
        public EducationViewModal educationViewModal { get; set; }

        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand ProjectsViewCommand { get; set; }
        public RelayCommand EducationViewCommand { get; set; }
        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModal()
        {
            homeViemModal = new HomeViewModal();
            projectsViewModal = new ProjectsViewModal();
            educationViewModal = new EducationViewModal();

            _currentView = homeViemModal;


            HomeViewCommand = new RelayCommand(x =>
            {
                CurrentView = homeViemModal;
            });
            ProjectsViewCommand = new RelayCommand(x =>
            {
                CurrentView = projectsViewModal;
            });
            EducationViewCommand = new RelayCommand(x =>
            {
                CurrentView = educationViewModal;
            });

        }
    }
}
