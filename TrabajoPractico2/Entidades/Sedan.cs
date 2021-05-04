﻿    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    class Sedan : Vehiculo
    {
        public enum ETipo { CuatroPuertas, CincoPuertas }

        ETipo tipo;

        /// <summary>
        /// Por defecto, TIPO será CuatroPuertas
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color) : base(chasis, marca, color)
        {
            tipo = ETipo.CuatroPuertas;
        }

        /// <summary>
        /// con set para tipo puertas
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color,ETipo puertas) : this(chasis, marca, color)
        {
            tipo = puertas;
        }


        /// <summary>
        /// Sedan son 'Mediano'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Mediano;
            }
        }

        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SEDAN");
            sb.AppendLine((string)this);
            sb.AppendLine("TAMAÑO : " + this.Tamanio.ToString());
            sb.AppendLine("TIPO : " + this.tipo.ToString());
            sb.AppendLine();
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
