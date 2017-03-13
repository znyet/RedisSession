# RedisSession
RedisSession
此类库使用Microsoft.Web.Redis源码编译，把StackExchange.Redis.StrongName替换成StackExchange.Redis。
web.config配置
<sessionState mode="Custom" customProvider="MySessionStateStore">
  <providers>
    <add name="MySessionStateStore" type="Microsoft.Web.Redis.RedisSessionStateProvider" connectionString="127.0.0.1:6379,allowadmin=true" accessKey="" ssl="false"/>
  </providers>
</sessionState>
这个就可以代替传统的内置session，防止session丢失。或者每次程序编译的时候session丢失。
