using System.Collections.Generic;

namespace EncosyTower.Mvvm.ComponentModel
{
    /// <summary>
    /// Any class implements this interface will be an eligible
    /// candidate to have its details generated by the corresponding generators.
    /// </summary>
    /// <seealso cref="EncosyTower.Mvvm.ComponentModel.ObservablePropertyAttribute"/>
    /// <seealso cref="EncosyTower.Mvvm.Input.RelayCommandAttribute"/>
    public interface IObservableObject
    {
        public bool TryGetMemberObservableObject(Queue<string> names, out IObservableObject result)
        {
            result = default;
            return false;
        }
    }
}
