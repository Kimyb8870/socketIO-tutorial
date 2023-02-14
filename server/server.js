const io = require("socket.io")(3000, {
  cors: {
    origin: ["http://localhost:4000"],
  },
});

io.on("connection", (socket) => {
  console.log(socket.id);

  socket.on("send-message", (message, room) => {
    //broadcast except sending socket
    //socket.broadcast.emit("receive-message", message);
    //broadcast to all socket
    //io.emit("receive-message", message);

    if (room === "") {
      socket.broadcast.emit("receive-message", message);
    } else {
      socket.to(room).emit("receive-message", message);
    }
  });

  socket.on("join-room", (room) => {
    socket.join(room);
  });
});
