﻿using FluentValidation;
using Mvc_Kutuphane_Otomasyonu.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc_Kutuphane_Otomasyonu.Entities.Validations
{
    public class EmanetKitaplarValidator:AbstractValidator<EmanetKitaplar>
    {
        public EmanetKitaplarValidator()
        {
           
        }
    }
}
