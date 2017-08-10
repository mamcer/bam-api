namespace BamApi.Core
{
    public class PlanInfo
    {
        public string ProjectKey { get; set; }

        public string ProjectName { get; set; }

        public string ShortName { get; set; }

        public string BuildName { get; set; }

        public string ShortKey { get; set; }

        public bool Enabled { get; set; }

        public Link Link { get; set; }

        public bool IsFavourite { get; set; }

        public bool IsActive { get; set; }

        public bool IsBuilding { get; set; }

        public double AverageBuildTimeInSeconds { get; set; }

        public string Key { get; set; }

        public string Name { get; set; }

        public Stages Stages { get; set; }

        public Branches Branches { get; set; }
    }
}