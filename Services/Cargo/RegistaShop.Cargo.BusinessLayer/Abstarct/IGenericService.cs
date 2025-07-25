﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistaShop.Cargo.BusinessLayer.Abstarct
{
	public interface IGenericService<T> where T : class
	{

		void TInsert(T entity);
		void TUpdate(T entity);
		void TDelete(int id);
		T TGetById(int id);
		List<T> TGetAll();

	}
}
