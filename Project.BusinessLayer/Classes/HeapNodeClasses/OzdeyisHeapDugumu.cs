using Project.BusinessLayer.Abstract_Classes;
using Project.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BusinessLayer.Classes.HeapNodeClasses
{
    public class OzdeyisHeapDugumu : HeapDugumu<Ozdeyis>
    {
        public Ozdeyis ozdeyis { get; set; }
        public OzdeyisHeapDugumu()
        {
            this.ozdeyis = ozdeyis;
        }
    }
}
