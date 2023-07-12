using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieRoller
{
	/// <summary>
	/// Represents a single six sided die (1 - 6)
	/// </summary>
	public class Die
	{
		private static Random _random;

		static Die()
		{
			_random = new Random(); // static constructor only gets called once
		}

		/// <summary>
		/// Creates the die and rolls it to start with a random number
		/// </summary>
        public Die()
        {
			Roll();
        }
        /// <summary>
        /// The current face up value of the die
        /// </summary>
        public byte FaceValue { get; private set; }

		/// <summary>
		/// True if the die is currently held
		/// </summary>
		public bool IsHeld { get; set; }

		/// <summary>
		/// Rolls the die and sets the <see cref="faceValue"/>
		/// to the new number if the die is not currently held.
		/// Retyrns the <see cref="faceValue"/>
		/// </summary>
		/// <returns> Returns the new random number </returns>
		public byte Roll()
		{
			if (!IsHeld)
			{
				// Generate random number
				byte newValue = (byte)_random.Next(1, 7);

				FaceValue = newValue;
			}
			return FaceValue;
		}
    }
}
