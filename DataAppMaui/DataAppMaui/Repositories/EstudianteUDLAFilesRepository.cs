using DataAppMaui.Interfaces;
using DataAppMaui.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAppMaui.Repositories
{
    public class EstudianteUDLAFilesRepository : IEstudianteUDLARepository
    {
        public string _fileName = Path.Combine(FileSystem.AppDataDirectory, "estudiantes.txt");
        public bool ActualizarEstudianteUDLA(EstudianteUDLA estudiante)
        {
            throw new NotImplementedException();
        }

        public bool CrearEstudianteUDLA(EstudianteUDLA estudiante)
        {
            // Se empleará el try-catch para validar que el archivo que estamos manipulando si existe, y de ser el caso de retornará True
            try
            {
                string estudiante_json = JsonConvert.SerializeObject(estudiante);
                File.WriteAllText(_fileName, estudiante_json);
                return true;
            }
            catch(Exception e)
            {
                throw;
            }
            
        }

        public bool EliminarEstudianteUDLA(int Id)
        {
            throw new NotImplementedException();
        }

        public EstudianteUDLA GetEstudianteUDLA(int Id)
        {
            /*
            return new EstudianteUDLA
            {
                Id = Id,
                Name = "Víctor",
                Carrera = "Ing. Software"
            };
            */
            EstudianteUDLA estudiante = new EstudianteUDLA();
            if (File.Exists(_fileName))
            {
                string data = File.ReadAllText(_fileName);
                estudiante = JsonConvert.DeserializeObject<EstudianteUDLA>(data);
            }
            return estudiante;
        }

        public List<EstudianteUDLA> GetListEstudiantesUDLA()
        {
            List<EstudianteUDLA> estudiantes = new List<EstudianteUDLA>();
            estudiantes.Add(GetEstudianteUDLA(1));
            estudiantes.Add(GetEstudianteUDLA(2));
            estudiantes.Add(GetEstudianteUDLA(3));

            return estudiantes;
        }
    }
}
