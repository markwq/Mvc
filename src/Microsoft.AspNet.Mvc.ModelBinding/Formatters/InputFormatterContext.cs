// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Text;
using Microsoft.AspNet.Http;

namespace Microsoft.AspNet.Mvc.ModelBinding
{
    public class InputFormatterContext
    {
        public InputFormatterContext([NotNull] HttpContext httpContext,
                                     [NotNull] ModelMetadata metadata, 
                                     [NotNull] ModelStateDictionary modelState)
        {
            HttpContext = httpContext;
            Metadata = metadata;
            ModelState = modelState;
        }

        public HttpContext HttpContext { get; private set; }

        public ModelMetadata Metadata { get; private set; }

        public ModelStateDictionary ModelState { get; private set; }

        public object Model { get; set; }
    }
}
