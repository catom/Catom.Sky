
1. Repository 与 UnitOfWork 的关系？
		Repository 关注的是数据处理的细节问题，如增删改查；而 UnitOfWork 关注的是连接、事物等的数据库方面的问题。
			关系图：	
				Repository		——>	Data/CRUD
				UnitOfWork	——>	DB/Connection
		1）两者间是不同角度的关系，而不是完全的包含关系；
		2）DAL 层的处理过程都是建立在 DbConnection 之上的，所以 Repository 类需要以 UnitOfWork 为成员；

2. 如何配置 IDAL 工具类？
		通过上面的包含关系，可知 DAL 层的配置需要
			1）初始化注入 UnitOfWork 类；
			2）BLL 层需要继承 Repository 类。
	
3. 具体配置，需要导入的 DLL 工具？
		DAL 层：
			1）导入 Dapper.dll ；
			2）导入 MySql.Data.dll ；
		UI 层：
			1）Unity 4 个 dll；
			2）Boostrapper.cs 引导并注入 IUnitOfWork；
			

》》》 WebApp 分层：
	1. 基本 DAL（Component 或 Provider）、BLL（Service）、UI（Web）；
	2. 层间联系：
		2.1 Component 层查询的简单实体（Entity），可作为 Service 层的调用中间数据，亦可直接返回到 Controller 层来使用，
					其实现通过自写扩展第三方 ORM 插件，实现单表的 CRUD 简单方法。
		2.2 Service 层的查询为多表查询（Model），直接返回到 Controller 层来使用，
					其实现可用通过 QueryManager 的 GetList 来实现（本质 Connection.Query<Entity>）, 实体用多表创建的复合实体即可，然后SQL在Service层自写。
		*注：在 Component 层实现多表查询，暂未找到实现方法。



















