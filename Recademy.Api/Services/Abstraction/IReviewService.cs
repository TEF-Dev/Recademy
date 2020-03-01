﻿using System.Collections.Generic;
using Recademy.Library.Dto;

namespace Recademy.Api.Services.Abstraction
{
    public interface IReviewService
    {
        List<ReviewRequestInfoDto> GetReviewRequests();
        ReviewRequestInfoDto AddReviewRequest(ReviewRequestAddDto reviewRequestAddDto);
        ReviewRequestInfoDto SendReviewResponse(SendReviewResponseDto reviewResponseDto);
        ReviewRequestInfoDto GetReviewInfo(int requestId);
    }
}