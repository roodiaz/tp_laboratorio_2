﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum EstadoJuego
    {
        faseDiseño,
        faseDesarrollo,
        faseTesteo,
        faseDistribucion
    }

    public enum Region
    {
        Region_1_USA,
        Region_2_Europa,
        Region_3_Asia,

    }

    public enum Plataforma
    {
        PlayStation4,
        PlayStation5,
        XboxOne,
        XboxSeries
    }
}
