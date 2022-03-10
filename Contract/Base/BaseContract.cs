using AutoMapper;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Logging;

namespace Contract.Base
{
    public abstract class BaseContract
    {
        protected readonly IMapper _mapper;

        //protected readonly ILogger _logger;

        protected readonly LogHelper _logHelper;

        protected BaseContract(IMapper mapper)
        {
            _mapper = mapper;

            //_logger = logger;

            _logHelper = new LogHelper();
        }
    }
}