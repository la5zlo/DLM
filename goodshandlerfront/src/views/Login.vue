<template>
    <body>
        <div class="login-container">
            <h2>Bejelentkezés</h2>
            <form action="/login" method="POST">
                <div class="form-group">
                    <label for="username">Felhasználónév</label>
                    <input 
                        type="text" 
                        id="username" 
                        name="username" required
                        v-model="username">
                </div>
                <div class="form-group">
                    <label for="password">Jelszó</label>
                    <input 
                        type="password" 
                        id="password" 
                        name="password" required
                        v-model="password">
                </div>
                <button 
                type="submit" 
                class="btn"
                @click.prevent="login()"
                >Bejelentkezés</button>
            </form>
        </div>
    </body>
</template>

<script setup>



</script>

<style scoped>
        * {
            box-sizing: border-box;
            margin: 0;
            padding: 0;
            font-family: Arial, sans-serif;
        }

        body {
            display: flex;
            justify-content: center;
            align-items: center;
            min-height: 100vh;
            background-color: #f0f2f5;
        }

        .login-container {
            width: 100%;
            max-width: 400px;
            padding: 2rem;
            background-color: #fff;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
            border-radius: 8px;
            text-align: center;
        }

        h2 {
            margin-bottom: 1rem;
            color: #333;
        }

        .form-group {
            margin-bottom: 1.5rem;
            text-align: left;
        }

        label {
            display: block;
            font-size: 0.9rem;
            color: #555;
            margin-bottom: 0.5rem;
        }

        input[type="text"],
        input[type="password"] {
            width: 100%;
            padding: 0.75rem;
            border: 1px solid #ddd;
            border-radius: 4px;
            font-size: 1rem;
        }

        input[type="text"]:focus,
        input[type="password"]:focus {
            border-color: #007bff;
            outline: none;
        }

        .btn {
            display: inline-block;
            width: 100%;
            padding: 0.75rem;
            font-size: 1rem;
            background-color: #007bff;
            color: #fff;
            border: none;
            border-radius: 4px;
            cursor: pointer;
            transition: background-color 0.3s;
        }

        .btn:hover {
            background-color: #0056b3;
        }

        .form-footer {
            margin-top: 1rem;
            font-size: 0.9rem;
        }

        .form-footer a {
            color: #007bff;
            text-decoration: none;
        }

        .form-footer a:hover {
            text-decoration: underline;
        }
    </style>