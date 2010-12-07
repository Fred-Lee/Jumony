﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ivony.Html.Parser.ContentModels
{
  public sealed class HtmlCommentContent : HtmlContentFragment
  {

    public HtmlCommentContent( HtmlContentFragment fragment, string comment )
      : base( fragment )
    {
      if ( comment == null )
        throw new ArgumentNullException( "comment" );

      Comment = comment;
    }

    public string Comment
    {
      get;
      private set;
    }

  }
}
