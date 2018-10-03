# WhatsAppApiUCU
Api para enviar mensajes por WhatsApp (usando Twilio)

Para utilizar esta biblioteca se deberá agregar una referencia a su proyecto y luego invocar el siguiente código:

```c#
var whatsApp = new WhatsAppApi(accountSid, authToken);
whatsApp.Send("+59899123456", "Hey! I'm using WhatsApp");
```

Las credeciales podran ser descargadas de Webasignatura