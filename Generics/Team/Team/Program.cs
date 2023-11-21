namespace Team
{
     class Program
    {
        static void Main(string[] args)
        {
            TeamMember member = new TeamMember();
            List<Squad> memberobj = member.AddMembers();
            member.DisplaySquad(memberobj);
            
        }
    }
}