FROM jtbennett/aspnet

COPY project.json /app/

WORKDIR /app
RUN bash -c "source $DNX_USER_HOME/dnvm/dnvm.sh && dnu restore"

COPY . /app

EXPOSE 5000

ENTRYPOINT ["dnx", "kestrel"]
