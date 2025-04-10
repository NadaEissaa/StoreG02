using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Car
    {
        #region attributes
        private int id;
		private int Speed;
		private string model;
        #endregion

        #region properties

		public Car()
		{
			Id = default;
			Model = default;
			Speed = default;
		}
        public string Model
		{
			get { return model; }
			set { model = value; }
		}


		public int Speed
		{
			get { return Speed; }
			set { Speed = value; }
		}


		public int Id
		{
			get { return id; }
			set { id = value; }
		}
        #endregion

        public override string ToString()
        {
            return $"Id : {id} , Speed: {Speed} , Model: {model}";
        }

        public string Address { get; set; }

    }
}
