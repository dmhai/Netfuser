namespace Netfuser.Core.Manglers.ControlFlow
{
    /// <summary>
    /// Control flow mangler options
    /// </summary>
    public class CFMangleOptions
    {
        /// <summary>
        /// Control flow mangler splits CIL blocks (see <see cref="Dnext.Cil.Block">)into smaller fragments, shuffles the fragments,
        /// and then uses different techniques to pass control from one fragment to the other.
        /// This option controls number of such fragments per CIL block. The higher the number, the more fragments per block will be created, 
        /// the stronger the obfuscation is, the more extra code is generated, the slower the execution speed will be
        /// </summary>
        public double Intensity = 0.6;

        /// <summary>
        /// Mangle methods may use <see cref="IntMangler"/> to obfuscate parameters to conditional branches, switches etc.
        /// This sets maximum number of arithmetic operations generated by the <see cref="IntMangler"/> to obfuscate a single integer.
        /// Larger value means stronger obfuscation, but more extra code and slower execution of the obfuscated method
        /// </summary>
        public int MaxMangleIterations = 10;
    }
}