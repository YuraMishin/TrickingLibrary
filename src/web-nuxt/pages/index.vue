<template>
  <div>
    <p>{{message}}</p>
    <p>{{messageAsyncData}}</p>
  </div>
</template>

<script>
  import Axios from "axios";

  export default {
    components: {},
    data: () => ({
      message: "Hello World basic!",
      messageAsyncData: "Hello World asyncData!"
    }),
    asyncData(payload){
      console.log("asyncData called")
      return Axios.get("http://localhost:5000/api/home")
        .then(({data}) => {
          return { messageAsyncData: data }
        })
    }
  }
</script>
