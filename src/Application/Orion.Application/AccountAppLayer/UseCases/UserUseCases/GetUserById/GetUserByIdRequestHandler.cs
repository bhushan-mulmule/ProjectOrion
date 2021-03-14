using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Orion.Application.AccountAppLayer.UseCases.UserUseCases.GetUserById
{
    public class GetUserByIdRequestHandler : IRequestHandler<GetUserByIdRequest, GetUserByIdResponse>
    {
        public async Task<GetUserByIdResponse> Handle(GetUserByIdRequest request, CancellationToken cancellationToken)
        {
            var user = new GetUserByIdResponse
            {
                Id = request.Id,
                Name = "John"
            };

            return user;
        }
    }
}
