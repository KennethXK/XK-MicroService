# 基础镜像使用nginx
FROM nginx
# 作者
MAINTAINER llp
# 添加时区环境变量，亚洲，上海
ENV TimeZone=Asia/Shanghai
COPY dist/ /usr/share/nginx/html/
COPY nginx/default.conf /etc/nginx/conf/conf.d/default.conf
