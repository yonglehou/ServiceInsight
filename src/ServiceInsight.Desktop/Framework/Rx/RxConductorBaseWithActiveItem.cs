﻿namespace Particular.ServiceInsight.Desktop.Framework.Rx
{
    using Caliburn.Micro;

    public abstract class RxConductorBaseWithActiveItem<T> : RxConductorBase<T>, IConductActiveItem where T : class
    {
        T activeItem;

        public T ActiveItem
        {
            get { return activeItem; }
            set { ActivateItem(value); }
        }

        object IHaveActiveItem.ActiveItem
        {
            get { return ActiveItem; }
            set { ActiveItem = (T)value; }
        }

        protected virtual void ChangeActiveItem(T newItem, bool closePrevious)
        {
            ScreenExtensions.TryDeactivate(activeItem, closePrevious);

            newItem = EnsureItem(newItem);

            if (IsActive)
                ScreenExtensions.TryActivate(newItem);

            activeItem = newItem;
            raisePropertyChanged("ActiveItem");
            OnActivationProcessed(activeItem, true);
        }
    }
}