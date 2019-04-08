using System;
using Xamarin.Forms;

namespace GuideXamarinForms.CustomControls
{
    public class CheckBoxs : View
    {
        //public static readonly BindableProperty IsCheckedProperty = BindableProperty.Create(nameof(IsChecked), typeof(bool), typeof(CheckBoxs), false);
        public static readonly BindableProperty CheckedProperty = BindableProperty.Create<CheckBoxs, bool>(p => p.Checked, false, BindingMode.TwoWay, propertyChanged: OnCheckedPropertyChanged);
        public event EventHandler<EventArgs<bool>> CheckedChanged;

        //public bool IsChecked
        //{
        //    get => (bool)GetValue(IsCheckedProperty);
        //    set => SetValue(IsCheckedProperty, value);
        //}

        /// <summary>
        /// Gets or sets a value indicating whether the control is checked.
        /// </summary>
        /// <value>The checked state.</value>
        public bool Checked
        {
            get
            {
                return this.GetValue<bool>(CheckedProperty);
            }

            set
            {
                if (this.Checked != value)
                {
                    this.SetValue(CheckedProperty, value);
                    this.CheckedChanged.Invoke(this, value);
                }
            }
        }

        private static void OnCheckedPropertyChanged(BindableObject bindable, bool oldvalue, bool newvalue)
        {
            var checkBox = (CheckBoxs)bindable;
            checkBox.Checked = newvalue;
        }
        //commnad parameter

        /// <summary>
        /// The bindable property implementation
        /// </summary>
        public static readonly BindableProperty CommandParameterProperty = BindableProperty.Create<CheckBoxs, object>(i => i.CommandParameter, default(object), BindingMode.OneWay);
        /// <summary>
        /// The command parameter
        /// </summary>
        public object CommandParameter
        {
            get
            {
                return this.GetValue(CommandParameterProperty);
            }
            set
            {
                this.SetValue(CommandParameterProperty, value);
            }
        }
        /// <summary>
        /// The bindable property implementation
        /// </summary>
        public static readonly BindableProperty CommandProperty = BindableProperty.Create<CheckBoxs, Command>(i => i.Command, null, BindingMode.OneWay);
        /// <summary>
        /// The command which gets executed on tapping the cell
        /// </summary>
        public Command Command
        {
            get
            {
                return (Command)this.GetValue(CommandProperty);
            }
            set
            {
                this.SetValue(CommandProperty, value);
            }
        }


    }

    public class EventArgs<T> : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventArgs"/> class.
        /// </summary>
        /// <param name="value">Value of the argument</param>
        public EventArgs(T value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Gets the value of the event argument
        /// </summary>
        public T Value { get; private set; }
    }

    public static class BindableObjectExtensions
    {
        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="bindableObject">The bindable object.</param>
        /// <param name="property">The property.</param>
        /// <returns>T.</returns>
        public static T GetValue<T>(this BindableObject bindableObject, BindableProperty property)
        {
            return (T)bindableObject.GetValue(property);
        }
    }

    public static class EventExtensions
    {
        /// <summary>
        /// Raise the specified event.
        /// </summary>
        /// <param name="handler">Event handler.</param>
        /// <param name="sender">Sender object.</param>
        /// <param name="value">Argument value.</param>
        /// <typeparam name="T">The value type.</typeparam>
        public static void Invoke<T>(this EventHandler<EventArgs<T>> handler, object sender, T value)
        {
            var handle = handler;
            if (handle != null)
            {
                handle(sender, new EventArgs<T>(value));
            }
        }

        /// <summary>
        /// Tries the invoke.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="handler">The handler.</param>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The arguments.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool TryInvoke<T>(this EventHandler<T> handler, object sender, T args) where T : EventArgs
        {
            var handle = handler;
            if (handle == null) return false;

            handle(sender, args);
            return true;
        }
    }
}
