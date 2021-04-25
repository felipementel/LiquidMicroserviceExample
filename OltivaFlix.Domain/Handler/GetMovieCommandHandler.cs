
using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using OltivaFlix.Domain.Command;
using OltivaFlix.Domain.Model;
using OltivaFlix.Domain.Service;
using Liquid.Domain;
using Liquid.Core.Context;
using Liquid.Core.Telemetry;
using AutoMapper;

namespace OltivaFlix.Domain.Handler
{
    public class GetMovieCommandHandler : RequestHandlerBase, IRequestHandler<GetMovieCommand, Movie>
    {


        private readonly IMovieServiceClient _movieService;
        
        public GetMovieCommandHandler(IMediator mediatorService, 
                                        ILightContext contextService, 
                                        ILightTelemetry telemetryService, 
                                        IMapper mapperService,
                                        IMovieServiceClient movieService) : base(mediatorService, contextService, telemetryService, mapperService)
        {
             _movieService = movieService;
        }

        public async Task<Movie> Handle(GetMovieCommand request, CancellationToken cancellationToken)
        {
            var response = await _movieService.SearchMovies("a");
            return null;
        }
    }
}
