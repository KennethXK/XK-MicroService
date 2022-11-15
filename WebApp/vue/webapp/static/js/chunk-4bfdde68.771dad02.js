(window["webpackJsonp"]=window["webpackJsonp"]||[]).push([["chunk-4bfdde68"],{"7c63":function(t,e,n){"use strict";n("b97b")},"9a73":function(t,e,n){},"9ed6":function(t,e,n){"use strict";n.r(e);var i=function(){var t=this,e=t.$createElement,n=t._self._c||e;return n("div",{staticClass:"login"},[n("el-form",{ref:"loginForm",staticClass:"login-form",attrs:{model:t.loginForm,rules:t.loginRules,"label-position":"left","label-width":"0px"}},[n("h3",{staticClass:"title"},[t._v("\n      ABP-MicroService 后台登录\n    ")]),t._v(" "),n("el-form-item",{attrs:{prop:"tenant"}},[n("el-input",{attrs:{type:"text","auto-complete":"off",placeholder:"租户"},model:{value:t.loginForm.tenant,callback:function(e){t.$set(t.loginForm,"tenant",e)},expression:"loginForm.tenant"}},[n("svg-icon",{staticClass:"el-input__icon input-icon",attrs:{slot:"prefix","icon-class":"cloud"},slot:"prefix"})],1)],1),t._v(" "),n("el-form-item",{attrs:{prop:"username"}},[n("el-input",{attrs:{type:"text","auto-complete":"off",placeholder:"账号"},model:{value:t.loginForm.username,callback:function(e){t.$set(t.loginForm,"username",e)},expression:"loginForm.username"}},[n("svg-icon",{staticClass:"el-input__icon input-icon",attrs:{slot:"prefix","icon-class":"user"},slot:"prefix"})],1)],1),t._v(" "),n("el-form-item",{attrs:{prop:"password"}},[n("el-input",{attrs:{type:"password","auto-complete":"off",placeholder:"密码"},nativeOn:{keyup:function(e){return!e.type.indexOf("key")&&t._k(e.keyCode,"enter",13,e.key,"Enter")?null:t.handleLogin(e)}},model:{value:t.loginForm.password,callback:function(e){t.$set(t.loginForm,"password",e)},expression:"loginForm.password"}},[n("svg-icon",{staticClass:"el-input__icon input-icon",attrs:{slot:"prefix","icon-class":"password"},slot:"prefix"})],1)],1),t._v(" "),n("el-form-item",{staticStyle:{width:"100%"}},[n("el-button",{staticStyle:{width:"100%"},attrs:{loading:t.loading,size:"medium",type:"primary"},nativeOn:{click:function(e){return e.preventDefault(),t.handleLogin(e)}}},[t.loading?n("span",[t._v("登 录 中...")]):n("span",[t._v("登 录")])])],1)],1)],1)},s=[],o=(n("ac6a"),n("456d"),n("1131")),r=n("c62e"),a=n("415c"),c={name:"Login",components:{LangSelect:o["a"],SocialSign:r["default"]},data:function(){var t=function(t,e,n){e.length<6?n(new Error("The password can not be less than 6 digits")):n()};return{loginForm:{tenant:void 0,username:"",password:"",client_id:a["a"].client.client_id,grant_type:a["a"].client.grant_type},loginRules:{username:[{required:!0,message:"username is required",trigger:"blur"}],password:[{required:!0,trigger:"blur",validator:t}]},passwordType:"password",capsTooltip:!1,loading:!1,showDialog:!1,redirect:void 0,otherQuery:{}}},watch:{$route:{handler:function(t){var e=t.query;e&&(this.redirect=e.redirect,this.otherQuery=this.getOtherQuery(e))},immediate:!0}},created:function(){},destroyed:function(){},methods:{checkCapslock:function(t){var e=t.key;this.capsTooltip=e&&1===e.length&&e>="A"&&e<="Z"},showPwd:function(){var t=this;"password"===this.passwordType?this.passwordType="":this.passwordType="password",this.$nextTick((function(){t.$refs.password.focus()}))},handleLogin:function(){var t=this;this.$refs.loginForm.validate((function(e){if(!e)return!1;t.loading=!0,t.$store.dispatch("user/userLogin",t.loginForm).then((function(){t.$router.push({path:t.redirect||"/",query:t.otherQuery}),t.loading=!1})).catch((function(){t.loading=!1}))}))},getOtherQuery:function(t){return Object.keys(t).reduce((function(e,n){return"redirect"!==n&&(e[n]=t[n]),e}),{})}}},l=c,u=(n("7c63"),n("2877")),d=Object(u["a"])(l,i,s,!1,null,null,null);e["default"]=d.exports},b97b:function(t,e,n){},bfec:function(t,e,n){"use strict";n("9a73")},c62e:function(t,e,n){"use strict";n.r(e);var i=function(){var t=this,e=t.$createElement,n=t._self._c||e;return n("div",{staticClass:"social-signup-container"},[n("div",{staticClass:"sign-btn",on:{click:function(e){return t.wechatHandleClick("wechat")}}},[n("span",{staticClass:"wx-svg-container"},[n("svg-icon",{staticClass:"icon",attrs:{"icon-class":"wechat"}})],1),t._v("\n    WeChat\n  ")]),t._v(" "),n("div",{staticClass:"sign-btn",on:{click:function(e){return t.tencentHandleClick("tencent")}}},[n("span",{staticClass:"qq-svg-container"},[n("svg-icon",{staticClass:"icon",attrs:{"icon-class":"qq"}})],1),t._v("\n    QQ\n  ")])])},s=[],o={name:"SocialSignin",methods:{wechatHandleClick:function(t){alert("ok")},tencentHandleClick:function(t){alert("ok")}}},r=o,a=(n("bfec"),n("2877")),c=Object(a["a"])(r,i,s,!1,null,"7309fbbb",null);e["default"]=c.exports}}]);