﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using forgeSampleAPI_DotNetCore.Entities.Abstract;

namespace forgeSampleAPI_DotNetCore.Services.Adapters.Abstract
{
    public interface IModelDetailServicesAdapter<M> where M:class,IModelDetails
    {
        Task<dynamic> GetModelDetailMetaDataAsync(M modelDetails);
        Task<dynamic> GetModelDetailPropertiesAsync(M modelDetails);

        dynamic GetModelDetailProperties(M modelDetails);

        Task<dynamic> GetModelDetailPropertiesAsyncByName(M modelDetails);

        Task<dynamic> GetModelDetailPropertiesAsyncByNamePattern(M modelDetails);
    }
}
