using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VidzyDbFirst
{
	class Program
	{
		static void Main(string[] args)
		{
			var dbContext = new VidzyDbContext();
			dbContext.AddVideo("una settimana da dio", new DateTime(1989, 1, 1), "Comedy", (byte?)ClassificationEnum.Gold);
			dbContext.AddVideo("jack reacher", new DateTime(1995, 1, 1), "Thriller", (byte?)ClassificationEnum.Platinum);
			dbContext.AddVideo("amici miei", new DateTime(1970, 1, 1), "Family", (byte?)ClassificationEnum.Silver);
			dbContext.AddVideo("caccia a ottobre rosso", new DateTime(1994, 1, 1), "Action", (byte?)ClassificationEnum.Gold);
		}
	}
}
