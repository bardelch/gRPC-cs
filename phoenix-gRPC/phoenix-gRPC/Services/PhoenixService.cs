using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace phoenix_gRPC
{
    public class PLC_phoenixService : phoenixService.phoenixServiceBase
    {
        /*
         * message phoenix_STATUS {
         * bool READY		= 1;
         * bool BUSY		= 2;
         * bool DONE		= 3;
         * bool PASS		= 4;
         * bool FAIL		= 5;
         * bool FAULTED	= 6;
         * }
        */
        public override global::System.Threading.Tasks.Task<global::phoenix_gRPC.phoenix_STATUS> PLC_Request(global::phoenix_gRPC.PLC_message_ELWEMA request, ServerCallContext context)
        {
            return Task.FromResult(new phoenix_STATUS
            {
                READY   = false,
                BUSY    = false,
                DONE    = false,
                PASS    = false,
                FAIL    = false,
                FAULTED = true
            });
        }
    }
}