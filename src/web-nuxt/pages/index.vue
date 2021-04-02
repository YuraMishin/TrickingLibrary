<template>
  <div>
    <p>{{message}}</p>
    <p>{{messageAsyncData}}</p>
    <p>{{messageVuex}}</p>
  </div>
</template>

<script>
  import Axios from "axios";
  import {mapActions, mapMutations, mapState} from 'vuex';

  export default {
    components: {},
    data: () => ({
      message: "Hello World basic!",
      messageAsyncData: "Hello World asyncData!"
    }),
    computed: {
      ...mapState(['messageVuex'])
    },
    asyncData(payload){
      console.log("asyncData called")
      return Axios.get("http://localhost:5000/api/home")
        .then(({data}) => {
          return { messageAsyncData: data }
        })
    },
    async fetch (){
      await this.$store.dispatch('fetchMessage');
    }
  }
</script>
