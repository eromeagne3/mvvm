using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace Em3.CommonUtilities.MVVM
{
    /// <summary>
    /// プロパティ変更通知イベントの発行インターフェース
    /// </summary>
    public interface IPropertyChangedNotificattor : INotifyPropertyChanged
    {
        /// <summary>
        /// プロパティに値をセットし、PropertyChangedイベントを発生させる。
        /// </summary>
        /// <param name="field">値設定先</param>
        /// <param name="newValue">新しい値</param>
        /// <param name="propertyName">プロパティ名</param>
        /// <returns>変更されればtrue</returns>
        bool Set<T>(ref T field, T newValue, [CallerMemberName]string propertyName = "");
    }
}
