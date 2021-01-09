using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using AuthService.Domain;

namespace AuthService.DataAccess
{
    public class InsuranceAgentsInMemoryDb : IInsuranceAgents
    {
        private readonly IDictionary<string, InsuranceAgent> _database = new ConcurrentDictionary<string, InsuranceAgent>();

        public InsuranceAgentsInMemoryDb()
        {
            Add(new InsuranceAgent("dusan.jovanovic", "secret", "static/avatars/jimmy_solid.png", new List<string>() {"TRI", "HSI", "FAI", "CAR"}));
            Add(new InsuranceAgent("stefan.mitic", "secret", "static/avatars/danny.solid.png", new List<string>() {"TRI", "HSI", "FAI", "CAR"}));
            Add(new InsuranceAgent("admin", "admin", "static/avatars/admin.png", new List<string>() {"TRI", "HSI", "FAI", "CAR"}));
        }
        
        public void Add(InsuranceAgent agent)
        {
            _database[agent.Login] = agent;
        }

        public InsuranceAgent FindByLogin(string login) => _database[login];
    }
}