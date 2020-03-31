using System;
using System.Collections.Generic;
using System.Text;

namespace ICommandYou
{
    using System.Threading.Tasks;

    /// <summary>
    /// The CommandHandler interface
    ///  ****Responsible for ensuring that the given command goes into the right direction***
    /// </summary>
    /// <typeparam name="T">
    /// </typeparam>
    public interface ICommandHandler<T> where T : ICommand
    {
        /// <summary>
        /// The handler async.
        /// </summary>
        /// <param name="command">
        /// The command.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task HandlerAsync(T command);
    }
}
