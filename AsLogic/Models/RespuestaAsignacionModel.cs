using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AsLogic.Models;

namespace AsLogic.Models
{
    public class RespuestaAsignacionModel
    {
        public RackStringModel rack { get; set; }
        public RackImagenesModel rackImagenesModel { get; set; }
        
        public RespuestaAsignacionModel( RackStringModel rack, RackImagenesModel rackImagenesModel)
        {
            this.rack = rack;
            this.rackImagenesModel = rackImagenesModel;
        }
    }
}
