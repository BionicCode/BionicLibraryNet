#region Info
// //  
// WpfTestRange.Main
#endregion

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BionicUtilities.NetStandard.ViewModel
{
  public interface IViewModel : INotifyPropertyChanged, INotifyDataErrorInfo
  {

    /// <summary>
    /// Checks whether the specified property has errors or is valid.
    /// </summary>
    /// <param name="propertyName">The name of the property to check for errors.</param>
    /// <returns><c>true</c> when the specified property has at least one error. Otherwise <c>false</c> when the property is valid.</returns>
    bool PropertyHasError([CallerMemberName] string propertyName = null);

    /// <summary>
    /// Gets all error messages of the specified property. If the <paramref name="propertyName"/> is <c>null</c> all error messages will be returned.
    /// </summary>
    /// <param name="propertyName">The of the property of which the error messages should be returned.</param>
    /// <returns>Returns an <see cref="IEnumerable{T}"/> containing all error messages of the specified property.</returns>
    /// <remarks>If the <paramref name="propertyName"/> is <c>null</c> all current error messages will be returned.</remarks>
    IEnumerable<string> GetPropertyErrors([CallerMemberName] string propertyName = null);
  }
}