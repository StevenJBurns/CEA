using System;
using System.Windows;
using System.Collections.Generic;
using System.Text;

using AirForce.Airdrop;

namespace AirForce
	{

	public interface IRectangularDZ
		{
		int Length { get; set;}
		int Width { get; set;}
		}

	public interface ICircularDZ
		{
		int Radius { get; set;}
		}

	public interface IAreaDZ
		{
		Point PointA { get; set;}
		Point PointB { get; set;}
		}

	public interface IWaterDZ
		{
		Boolean IsWater { get; set;}
		}

	public abstract class Dropzone
		{
		private String dz_id;
		private String dz_name;
		private Boolean dz_common;
		private Boolean dz_activerecord;
		private DropzoneType dz_type;

		public String DZ_ID
			{
			get { return dz_id; }
			set { dz_id = value; }
			}

		public String Name
			{
			get { return dz_name; }
			set { dz_name = value; }
			}

		public Boolean CommonUse
			{
			get { return dz_common; }
			set { dz_common = value; }
			}

		public Boolean ActiveRecord
			{
			get { return dz_activerecord; }
			set { dz_activerecord = value; }
			}

		public DropzoneType Type
			{
			get { return dz_type; }
			set { dz_type = value; }
			}

		public Dropzone()
			{
			this.dz_id = "ID Not Set";
			this.dz_name = "Name Not Set";
			this.dz_common = true;
			this.dz_activerecord = true;
			}

		public Dropzone(String id, String name, Boolean common)
			{
			this.dz_id = id;
			this.dz_name = name;
			this.dz_common = common;
			this.dz_activerecord = true;
			}

		}

	}