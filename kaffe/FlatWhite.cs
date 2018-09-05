using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaffe
{
    /// <summary>
    /// Flat White klasse, nedarver fra Kaffe klassen og Imælk interfacet
    /// </summary>
    public class FlatWhite : Kaffe , Imælk
    {
        /// <summary>
        /// hvor meget mælk skal bruges i FlatWhite?
        /// </summary>
        /// <returns></returns>
        public int MlMælk()
        {
            return 160;
        }

        /// <summary>
        /// hvor meget koster FlatWhite?
        /// </summary>
        /// <returns></returns>
        public override int Pris()
        {
            return 45;
        }

        /// <summary>
        /// hvad er styrken på FlatWhite?
        /// </summary>
        /// <returns></returns>
        public override string Styrke()
        {
            return "mild";
        }
    }
}