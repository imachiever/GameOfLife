﻿namespace SampleCode.GameOfLifeCore.Base
{
    /// <summary>
    /// interface to be implemented by a class
    /// which will act as rule on a <see cref="ICell"/>
    /// object
    /// </summary>
    /// <typeparam name="TC"></typeparam>
    /// <typeparam name="TG"></typeparam>
    public interface ICellRule<TC, TG> where TC:ICell
                                       where TG:IGrid<TC>
    {
        /// <summary>
        /// Acts on the <paramref name="cell"/>
        /// to execute the rule using <see cref="NeighbourCellsFinder"/>
        /// and <see cref="Grid"/>
        /// </summary>
        /// <param name="cell"></param>
        void Execute(TC cell);

        /// <summary>
        /// gets/sets instance of class implementing
        /// <see cref="INeighbourCellsFinder{TC,TG}"/>.
        /// Used by the <see cref="Execute"/> method to
        /// implement the rule.
        /// </summary>
        INeighbourCellsFinder<TC, TG> NeighbourCellsFinder { get; set; }

        /// <summary>
        /// gets/sets instance of class implementing
        /// <see cref="IGrid{TC}"/>. Used by the 
        /// <see cref="Execute"/> method to implement the 
        /// rule
        /// </summary>
        TG Grid { get; set; }
    }
}