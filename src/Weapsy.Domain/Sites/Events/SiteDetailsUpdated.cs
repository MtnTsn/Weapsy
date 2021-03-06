﻿using System.Collections.Generic;
using Weapsy.Infrastructure.Domain;

namespace Weapsy.Domain.Sites.Events
{
    public class SiteDetailsUpdated : DomainEvent
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeywords { get; set; }
        public bool AddLanguageSlug { get; set; }
        public IEnumerable<SiteLocalisation> SiteLocalisations { get; set; } = new List<SiteLocalisation>();
    }
}
