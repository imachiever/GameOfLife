using System.Collections.Generic;

namespace SampleCode.GameOfLifeCore.Base
{
    /// <summary>
    /// interface to be implemented by a class
    /// which can be used to return neighboring
    /// cells of any particular cell
    /// </summary>
    /// <typeparam name="TC"></typeparam>
    /// <typeparam name="TG"></typeparam>
    public interface INeighbourCellsFinder<TC, TG> where TC:ICell
                                                  where TG:IGrid<TC>
    {
        /// <summary>
        /// Fetches cells which are neighbors to the 
        /// cell represented by the position - 
        /// <paramref name="rowIndex"/> and 
        /// <paramref name="columnIndex"/>
        /// </summary>
        /// <param name="rowIndex"></param>
        /// <param name="columnIndex"></param>
        /// <returns></returns>
        IEnumerable<TC> RetrieveNeighbours(int rowIndex, int columnIndex);

        /// <summary>
        /// gets/sets the grid which will be 
        /// used by <see cref="RetrieveNeighbours"/>
        /// to calculate the neighbors of a cell
        /// </summary>
        TG Grid { get; set; }
    }
}