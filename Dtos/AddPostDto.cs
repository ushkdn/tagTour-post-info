﻿namespace tagTour_post_info.Dtos
{
    public class AddPostDto
    {
        public string Title { get; set; }
        public string? Description { get; set; } = "";
        public string[]? Media { get; set; }
        public int Author { get; set; }
        public string[] Tags { get; set; }
    }
}