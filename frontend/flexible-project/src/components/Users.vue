<script setup>
import { ref } from 'vue'
import User from './Users.vue'

const {users} = defineProps(['users'])
</script>

<template>
    <div class="wrapper">
        <h1>Users list:</h1>

        <div v-for="user in users">
            <div class="user">
                <img v-bind:src="user?.picture">
                <div class="user-text">
                    <div class="user-text-name">
                        <h2>{{ user?.first }}</h2>
                        <h2>{{ user?.last }}</h2>
                    </div>
                    <h3>{{ user?.email }}</h3>
                </div>
            </div>
        </div>
    </div> 
</template>

<style scoped>
@media (min-width: 1024px) {
    .wrapper {
        display: flex;
        flex-direction: column;
        margin-left: 1rem;
    }
}

.user img {
    border-radius: 50%;
    border: 2px solid var(--main-color-green);
    max-width: 100%;
    height: auto;
    margin:1rem 1rem;
}

.user {
    display: flex;
    align-items: center;
    background-color: var(--color-background);
    padding: 0.3rem;
    border-radius: 3rem;
    margin: 1rem 0;
}

.user-text-name {
    color: var(--main-color-green);
    font-family: 'Poppins', 'Roboto', monospace;
    font-weight: 700;
    display: flex;
}

.user-text-name h2{
margin-right: 0.7rem;
}
</style>






