<script setup>
import { ref } from 'vue'
import Header from './components/Header.vue'
import Users from './components/Users.vue'

let users = ref([])

function updateUsers(usersJson) {
  console.log(usersJson)
  users.value = usersJson
}
</script>

<template>
  <div class="container">
    <Header @fetch-users="updateUsers"></Header>
    <Users :users="users" />
  </div>
</template>


