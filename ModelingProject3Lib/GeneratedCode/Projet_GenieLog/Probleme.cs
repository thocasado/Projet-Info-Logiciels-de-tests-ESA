﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Projet_GenieLog
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	private class Probleme
	{
		public virtual string _bonneRep
		{
			get;
			set;
		}

		public virtual string _choix1
		{
			get;
			set;
		}

		public virtual string _choix2
		{
			get;
			set;
		}

		public virtual string _choix3
		{
			get;
			set;
		}

		public virtual string _choix4
		{
			get;
			set;
		}

		public virtual string _consigne
		{
			get;
			set;
		}

		public virtual int _id
		{
			get;
			set;
		}

		public virtual string _image
		{
			get;
			set;
		}

		public Probleme(int id, string consigne, string c1, string c2, string c3, string c4, string br, string image)
		{
		}

		public static IEnumerable<Probleme> selectionPbm(string matiere, bool difficile)
		{
			throw new System.NotImplementedException();
		}

	}
}

