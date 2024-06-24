﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Services.Multiidioma;

namespace BLL
{
    public class TraduccionBLL
    {
        MP_Traduccion mpTraduccion = new MP_Traduccion();
        public void GuardarTraducciones(IList<Traduccion> traducciones)
        {
            foreach (var traduccion in traducciones)
            {
                mpTraduccion.Insert(traduccion);
            }
        }
    }
}
