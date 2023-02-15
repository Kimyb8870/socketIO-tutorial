const io = require("socket.io")(3000, {
  cors: {
    origin: ["http://localhost:4000"],
  },
});

io.on("connection", (socket) => {
  console.log(socket.id);

  socket.on("control-init", (message, device) => {
    //broadcast except sending socket
    //socket.broadcast.emit("receive-message", message);
    //broadcast to all socket
    //io.emit("receive-message", message);

    if (device === "") {
      socket.broadcast.emit("control-request", message);
    } else {
      socket.to(device).emit("control-request", message);
    }
  });

  socket.on("control-finish", (message) => {
    io.emit("control-response", message);
  });

  socket.on("join-room", (device) => {
    socket.leave();
    socket.join(device);
  });
});
