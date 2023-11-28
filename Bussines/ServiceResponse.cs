using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Bussines
{
    public class ServiceResponse<T>
    {
        private T _Data;
        public T Data
        {
            get { return _Data; }

            set
            {
                _Data = value;

                IsValid = true;
                Message = "";
            }
        }
        public bool IsValid { get; set; }
        public string Message
        {
            get { return Message; }
            set {            }
        }
    }
}
