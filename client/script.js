import { io } from "socket.io-client";

const joinRoomButton = document.querySelector("#room-button");
const messageInput = document.querySelector("#message-input");
const roomInput = document.querySelector("#room-input");
const form = document.querySelector("#form");

const socket = io("http://localhost:3000");
// const socket = io("http://192.168.0.7:3000");

socket.on("connect", () => {
  displayMessage(`You connected wiht id : ${socket.id}`);
});

socket.on("control-response", (message) => {
  displayMessage(message);
});

form.addEventListener("submit", (e) => {
  e.preventDefault();

  const message = messageInput.value;
  const room = roomInput.value;

  if (message === "") return;
  //displayMessage(message);
  socket.emit("control-init", message, room);

  messageInput.value = "";
});

// joinRoomButton.addEventListener("click", () => {
//   const room = roomInput.value;

//   socket.emit("join-room", room);
// });

function displayMessage(message) {
  const div = document.createElement("div");

  div.textContent = message;
  document.getElementById("message-container").append(div);
}
