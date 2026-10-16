// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.



function openChat(userId, userName) {
    const container = document.getElementById("chatContainer");
    const chatId = `chat-${userId}`;

    if (document.getElementById(chatId)) {
        return;
    }

    const chat = document.createElement("div");

    chat.id = chatId;
    chat.className = "card shadow";
    chat.style.width = "320px";
    chat.style.height = "380px";

    chatinnerHTML = `
    <div class="card-header bg-primary text-white d-flex justify-content-between">

        <strong class="chat-user-name"></strong>

        <button type="button" class="btn btn-sm text-white" onclick="closeChat('${chatId}')">x</button>

    </div>

    <div class="card-body overflow-auto">
    <p class="text-muted">
        Henüz mesaj yok!
    </p>
    </div>

    <div class="card-footer">
         <input type="text" class="form-control" placeholder="Mesaj yaz..."/>
    </div>

    `;

    chat.querySelector(".chat-user-name").textContent = userName;

    container.appendChild(chat);

}

function closeChat(chatId) {
    document.getElementById(chatId)?.remove();
}