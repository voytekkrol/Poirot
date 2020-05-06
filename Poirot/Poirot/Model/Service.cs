namespace Poirot.Model
{
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Service 
	{
		private int id;

		[PrimaryKey, AutoIncrement ]
		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		private int machineId;
		[Indexed]
		public int MachineId
		{
			get { return machineId; }
			set { machineId = value; }
		}

		private int printShopId;
		[Indexed]
		public int PrintShopId
		{
			get { return printShopId; }
			set { printShopId = value; }
		}

		private int hours;

		public int Hours
		{
			get { return hours; }
			set { hours = value; }
		}

		private string title;

		public string Title
		{
			get { return title; }
			set { title = value; }
		}

		private string serviceman1;

		public string Serviceman1
		{
			get { return serviceman1; }
			set { serviceman1 = value; }
		}

		private string serviceman2;

		public string Serviceman2
		{
			get { return serviceman2; }
			set { serviceman2 = value; }
		}

		private DateTime createdTime;

		public DateTime CreatedTime
		{
			get { return createdTime;}
			set 
			{ 
				createdTime = value;
				CreatedTimeFormat = value.ToString("dd.mm.yyyy");
			}

		}

		private DateTime updatedTime;

		public DateTime UpdatedTime
		{
			get { return updatedTime; }
			set { updatedTime = value; }
		}

		private string createdTimeFormat;

		public string CreatedTimeFormat
		{
			get { return createdTimeFormat; }
			set { createdTimeFormat = value; ; }
		}

		private string description;

		public string Description
		{
			get { return description; }
			set { description = value; }
		}



	}
}
