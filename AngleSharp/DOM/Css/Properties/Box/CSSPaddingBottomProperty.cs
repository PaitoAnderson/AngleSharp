﻿namespace AngleSharp.DOM.Css
{
    using AngleSharp.Css;

    /// <summary>
    /// Information can be found on MDN:
    /// https://developer.mozilla.org/en-US/docs/Web/CSS/padding-bottom
    /// </summary>
    sealed class CSSPaddingBottomProperty : CSSPaddingPartProperty, ICssPaddingBottomProperty
    {
        #region ctor

        internal CSSPaddingBottomProperty(CssStyleDeclaration rule)
            : base(PropertyNames.PaddingBottom, rule)
        {
        }

        #endregion

        #region Property

        public Length Bottom
        {
            get { return Padding; }
        }

        #endregion
    }
}
