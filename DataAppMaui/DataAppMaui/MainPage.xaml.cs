using DataAppMaui.Models;
using DataAppMaui.Repositories;

namespace DataAppMaui
{
    public partial class MainPage : ContentPage
    {
        public EstudianteUDLA estudiante;
        EstudianteUDLAFilesRepository _repository;

        public MainPage()
        {
            InitializeComponent();
            _repository = new EstudianteUDLAFilesRepository();
            estudiante = _repository.GetEstudianteUDLA(1);

            BindingContext = estudiante;
        }

        private void BotonSaveStudent_Clicked(object sender, EventArgs e)
        {
            EstudianteUDLA estudiante = new EstudianteUDLA
            {
                Id = 2,
                Name = "Víctor Suquilanda",
                Carrera = "Ingeniería de Software"
            };
            _repository.CrearEstudianteUDLA(estudiante);
        }
    }

}
