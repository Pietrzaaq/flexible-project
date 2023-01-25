<script setup>
  import { ref, defineEmits } from 'vue';
  const numberOfUsers = ref(false);

  const emit = defineEmits(['click', 'fetch-users'])

  function fetchUsers(numberOfUsers) {
    if (numberOfUsers < 1)
    {
      alert("Number of users must be at least 1")
      return;
    }

    const url = `http://localhost:5000/api/users?numberOfUsers=${numberOfUsers}`

    fetch(url).then((res) =>{
      if (res.ok) {
        return res.json()
      }
      throw new Error("Error while fetching data from API")
    })
    .then((responseJson) => {
      const usersJson = responseJson
      emit('fetch-users', usersJson)
    })
  };
</script>

<template>
  <div class="wrapper">
    <h1 class="header-title">
      <span class="green-header-title">Flexible</span> 
      <span class="gray-header-title">Project</span>
    </h1>
    <h3> Welcome! Please insert the <span class="green">number</span> of users that you would like to see</h3>
    <input type="number" min="1" v-model="numberOfUsers"/>
    <button @click="fetchUsers(numberOfUsers)">OK</button>
  </div>
</template>

<style scoped>
h3 {
  font-size: 1.2rem;
  font-family: "Poppins";
  font-weight: 700;
}

input, button {
  font-weight: 700;
  font-family: 'Poppins', 'Roboto', monospace;
  background-color: var(--color-background);
  padding: 0.5rem 1rem;
  border: 2px solid var(--color-text);
  border-radius: 0.5em;
  margin: 0.5rem 0;
  color: var(--color-text);
}

form input {
  margin-right: 0.5rem;
}

.wrapper {
  display: flex;
  flex-direction: column;
  align-items: flex-start;
  border: 4px solid var(--main-color-green);
}

.header-title {
  font-size: 2.6rem;
  word-wrap: break-word;
}

.header-title .green-header-title,
.header-title .gray-header-title {
  font-family: 'Roboto';
  font-weight: 700;
}

.green-header-title {
  color: var(--main-color-green)
}
</style>
