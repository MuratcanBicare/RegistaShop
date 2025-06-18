using RegistaShop.Cargo.DataAccessLayer.Abstract;
using RegistaShop.Cargo.DataAccessLayer.Concrete;
using RegistaShop.Cargo.DataAccessLayer.Repositories;
using RegistaShop.Cargo.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistaShop.Cargo.DataAccessLayer.EntityFramework
{
	public class EfCargoDetailDal : GenericRepository<CargoDetail>, ICargoDetailDal
	{

		public EfCargoDetailDal(CargoContext context) : base(context)
		{

		}

	}
}
