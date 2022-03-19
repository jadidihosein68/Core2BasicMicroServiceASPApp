
The soloution cover 

A single microservice  soloution with out implimentation of authentication

The soloution covers following concepts 

The project use swagger to present API
CorsPolicy enabeled
ASP.net core default Depenency injection is used.
Option pattern implimented to read appsetting.
Fluent API has been used instead of model annotation so EF does not tidly coupled to models and u can change EF to ADO etc any times.
Automapper used for DTO 
httpclient factorry is added to soloution

a service layers from btn to top  

Adaptor : responsible to retrive/update data in any external form othe rthan db context 
Repository : Aa interface to call adaptor and DBcontext so adaptrer and db implimentation can change any time. 
Application : utilize repository and contain application logics 
Controller : utilize application and do mapping, validaiton and auth checking 

We use httpclient to coomunicate other services, however u can add any other protocol in adaptor layer

The soloution conrtains multiple projects 
API : contain all the controller and the mapping profile.
Service.Common : Shared utilities among all are located here .
MicroService.Common : framework related classes are sit here, example auth etc.
Services : contain the 4 layers explained on above.




