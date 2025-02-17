﻿using DataAppMaui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAppMaui.Interfaces
{
    public interface IEstudianteUDLARepository
    {
        List<EstudianteUDLA> GetListEstudiantesUDLA();
        EstudianteUDLA GetEstudianteUDLA(int Id);
        Boolean CrearEstudianteUDLA(EstudianteUDLA estudiante);
        Boolean ActualizarEstudianteUDLA(EstudianteUDLA estudiante);
        Boolean EliminarEstudianteUDLA(int Id);
    }
}
